echo "Running semgrep ($1) here"
semgrep --config=p/$1 ./*
for d in */ ; do
	echo "Running semgrep ($1) on $d"
	semgrep --config=p/$1 $d/*
done
